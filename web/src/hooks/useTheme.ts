import { ThemeConfig, theme } from "antd";
import { useState } from "react";

const { defaultAlgorithm, darkAlgorithm, compactAlgorithm } = theme;

const darkAndCompactAlgorithm = [darkAlgorithm, compactAlgorithm];
const defaultAndCompactAlgorithm = [defaultAlgorithm, compactAlgorithm];

const defaultTheme = {
  algorithm: defaultAndCompactAlgorithm,
} as ThemeConfig;

// TODO: persist preference in local storage
// TODO: check browser's theme preference
export const useTheme = (): {
  theme: ThemeConfig;
  setDarkTheme: (darkTheme: boolean) => void;
} => {
  const [theme, setTheme] = useState(defaultTheme);

  const setDarkTheme = (darkTheme: boolean) =>
    darkTheme
      ? setTheme({ ...theme, algorithm: darkAndCompactAlgorithm })
      : setTheme({ ...theme, algorithm: defaultAndCompactAlgorithm });

  return { theme, setDarkTheme };
};
