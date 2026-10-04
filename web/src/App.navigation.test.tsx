import { fireEvent, render, screen } from "@testing-library/react";
import { App } from "./App";

jest.mock("./components", () => {
  const { useState } = jest.requireActual<typeof import("react")>("react");
  const { useHistory } =
    jest.requireActual<typeof import("react-router-dom")>("react-router-dom");
  return {
    ListsTable: function MockListsTable() {
      const [filtered, setFiltered] = useState(false);
      const history = useHistory();
      return (
        <>
          <button onClick={() => setFiltered(true)}>
            {filtered ? "Filtered lists" : "All lists"}
          </button>
          <button onClick={() => history.push("/lists/example")}>
            Open list details
          </button>
          <button onClick={() => history.push("/")}>Close list details</button>
        </>
      );
    },
  };
});

test.each(["/", "/lists/example"])(
  "clicking the logo restores the initial table from %s",
  (path) => {
    window.history.replaceState({}, "", path);
    render(<App />);
    fireEvent.click(screen.getByRole("button", { name: "All lists" }));
    expect(
      screen.getByRole("button", { name: "Filtered lists" }),
    ).toBeInTheDocument();

    fireEvent.click(screen.getByRole("link", { name: "FilterLists logo" }));

    expect(window.location.pathname).toBe("/");
    expect(
      screen.getByRole("button", { name: "All lists" }),
    ).toBeInTheDocument();

    fireEvent.click(screen.getByRole("button", { name: "All lists" }));
    fireEvent.click(screen.getByRole("link", { name: "FilterLists logo" }));
    expect(
      screen.getByRole("button", { name: "All lists" }),
    ).toBeInTheDocument();
  },
);

test("opening and closing list details preserves the current table state", () => {
  window.history.replaceState({}, "", "/");
  render(<App />);
  fireEvent.click(screen.getByRole("button", { name: "All lists" }));

  fireEvent.click(screen.getByRole("button", { name: "Open list details" }));
  expect(window.location.pathname).toBe("/lists/example");
  expect(
    screen.getByRole("button", { name: "Filtered lists" }),
  ).toBeInTheDocument();

  fireEvent.click(screen.getByRole("button", { name: "Close list details" }));
  expect(window.location.pathname).toBe("/");
  expect(
    screen.getByRole("button", { name: "Filtered lists" }),
  ).toBeInTheDocument();
});

test.each(["ctrlKey", "metaKey", "shiftKey", "altKey"])(
  "%s-clicking the logo preserves the current table state",
  (modifier) => {
    window.history.replaceState({}, "", "/");
    render(<App />);
    fireEvent.click(screen.getByRole("button", { name: "All lists" }));

    fireEvent.click(screen.getByRole("link", { name: "FilterLists logo" }), {
      [modifier]: true,
    });

    expect(
      screen.getByRole("button", { name: "Filtered lists" }),
    ).toBeInTheDocument();
  },
);
