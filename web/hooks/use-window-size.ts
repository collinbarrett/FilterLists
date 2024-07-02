// https://usehooks.com/usewindowsize
import React from "react";

type Size = {
  width: number | undefined;
  height: number | undefined;
};

export function useWindowSize() {
  const [size, setSize] = React.useState<Size>({
    width: typeof window !== "undefined" ? window.innerWidth : undefined,
    height: typeof window !== "undefined" ? window.innerHeight : undefined,
  });

  React.useLayoutEffect(() => {
    const handleResize = () => {
      const { innerWidth, innerHeight } = window;
      setSize((prevSize) => {
        if (prevSize.width !== innerWidth || prevSize.height !== innerHeight) {
          return {
            width: innerWidth,
            height: innerHeight,
          };
        }
        return prevSize;
      });
    };

    window.addEventListener("resize", handleResize);
    handleResize();

    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  return size;
}
