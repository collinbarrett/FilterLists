import { fireEvent, render, screen, within } from "@testing-library/react";
import { Table } from "antd";
import { useSearchColumnFilter } from "./useSearchColumnFilter";

const SearchTable = () => {
  const filter = useSearchColumnFilter<{ id: number; description?: string }>(
    "description",
  );
  return (
    <Table
      rowKey="id"
      pagination={false}
      dataSource={[
        { id: 1, description: "Blocks Facebook trackers" },
        { id: 2, description: "Blocks advertisements" },
        { id: 3 },
      ]}
      columns={[{ title: "Description", dataIndex: "description", ...filter }]}
    />
  );
};

beforeEach(() => {
  Object.defineProperty(window, "matchMedia", {
    writable: true,
    value: jest.fn().mockImplementation(() => ({
      matches: false,
      addListener: jest.fn(),
      removeListener: jest.fn(),
    })),
  });
});

test("Reset immediately clears an applied search without another Search click", async () => {
  render(<SearchTable />);
  const openSearch = () =>
    fireEvent.click(
      within(screen.getByRole("columnheader")).getByRole("button"),
    );

  openSearch();
  fireEvent.change(await screen.findByPlaceholderText("Search Description"), {
    target: { value: "FACEBOOK" },
  });
  fireEvent.click(screen.getByRole("button", { name: /Search$/ }));

  expect(screen.getByText("Blocks Facebook trackers")).toBeInTheDocument();
  expect(screen.queryByText("Blocks advertisements")).not.toBeInTheDocument();
  expect(screen.getAllByRole("row")).toHaveLength(2);

  openSearch();
  fireEvent.click(await screen.findByRole("button", { name: "Reset" }));

  expect(await screen.findByText("Blocks advertisements")).toBeInTheDocument();
  expect(screen.getAllByRole("row")).toHaveLength(4);

  openSearch();
  expect(await screen.findByPlaceholderText("Search Description")).toHaveValue(
    "",
  );
  fireEvent.change(screen.getByPlaceholderText("Search Description"), {
    target: { value: "advertisements" },
  });
  fireEvent.keyDown(screen.getByPlaceholderText("Search Description"), {
    key: "Enter",
    code: "Enter",
    charCode: 13,
    keyCode: 13,
  });

  expect(screen.getByText("Blocks advertisements")).toBeInTheDocument();
  expect(
    screen.queryByText("Blocks Facebook trackers"),
  ).not.toBeInTheDocument();
});
