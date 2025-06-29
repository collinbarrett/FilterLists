"use client";

import { useCallback, useLayoutEffect } from "react";

const debounce = (func: () => void, delay: number) => {
  let timeoutId: NodeJS.Timeout;
  return () => {
    clearTimeout(timeoutId);
    timeoutId = setTimeout(func, delay);
  };
};

const ROW_HEIGHT = 64;
const VERTICAL_PADDING = 80 + 32 + 40 + 32 + 24;
const DEBOUNCE_DELAY = 150;

export function useCalculatePageSize(setPageSize: (size: number) => void) {
  const calculatePageSize = useCallback(() => {
    const availableHeight = window.innerHeight - VERTICAL_PADDING;
    const newPageSize = Math.max(1, Math.floor(availableHeight / ROW_HEIGHT));
    setPageSize(newPageSize);
  }, [setPageSize]);

  useLayoutEffect(() => {
    calculatePageSize();
    const handleResize = debounce(calculatePageSize, DEBOUNCE_DELAY);
    window.addEventListener("resize", handleResize);
    return () => window.removeEventListener("resize", handleResize);
  }, [calculatePageSize]);
}
