import { fireEvent, render, screen } from "@testing-library/react";
import { App } from "./App";

jest.mock("./components", () => {
  const { useState } = jest.requireActual<typeof import("react")>("react");
  return {
    ListsTable: function MockListsTable() {
      const [filtered, setFiltered] = useState(false);
      return (
        <button onClick={() => setFiltered(true)}>
          {filtered ? "Filtered lists" : "All lists"}
        </button>
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
