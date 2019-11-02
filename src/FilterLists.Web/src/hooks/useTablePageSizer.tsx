import { useEffect, useState } from "react";

interface TablePageSize {
  pageSize: number;
  isNarrowWindow: boolean;
  isWideWindow: boolean;
}

export const useTablePageSizer = () => {
  const [state, setState] = useState<TablePageSize>(calculateSize());
  useEffect(() => {
    const updatePageSize = () => setState(calculateSize());
    window.addEventListener("resize", updatePageSize);
    return () => window.removeEventListener("resize", updatePageSize);
  }, []);
  return state;
};

const calculateSize = () => ({
  pageSize: Math.floor((window.innerHeight - 184) / 57),
  isNarrowWindow: window.innerWidth < 576 ? true : false,
  isWideWindow: window.innerWidth > 1918 ? true : false
});
