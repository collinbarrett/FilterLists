import { ThemeConfig, theme } from "antd";
import { useState, useEffect } from "react";

const { defaultAlgorithm, darkAlgorithm, compactAlgorithm } = theme;

const darkCompactAlgorithm = [darkAlgorithm, compactAlgorithm];
const defaultCompactAlgorithm = [defaultAlgorithm, compactAlgorithm];
const defaultTheme = {
  algorithm: defaultCompactAlgorithm,
};
const appPreferDarkKey = "darkTheme";

export const useTheme = (): {
  theme: ThemeConfig;
  setDarkTheme: (darkTheme: boolean) => void;
} => {
  const [currentTheme, setTheme] = useState<ThemeConfig | null>(null);

  useEffect(() => {
    setTheme({
      ...defaultTheme,
      algorithm: getInitialAlgorithm(),
    });
  }, []);

  useEffect(() => {
    if (currentTheme) {
      localStorage.setItem(
        appPreferDarkKey,
        currentTheme.algorithm === darkCompactAlgorithm ? "true" : "false"
      );
    }
  }, [currentTheme]);

  const setDarkTheme = (darkTheme: boolean) => {
    if (currentTheme) {
      darkTheme
        ? setTheme({ ...currentTheme, algorithm: darkCompactAlgorithm })
        : setTheme({ ...currentTheme, algorithm: defaultCompactAlgorithm });
    }
  };

  return { theme: currentTheme || defaultTheme, setDarkTheme };
};

const getInitialAlgorithm = () => {
  const appPreferDark = localStorage.getItem(appPreferDarkKey);
  if (appPreferDark !== null) {
    return appPreferDark === "true"
      ? darkCompactAlgorithm
      : defaultCompactAlgorithm;
  }

  const browserPreferDark =
    window.matchMedia?.("(prefers-color-scheme: dark)")?.matches ?? false;
  return browserPreferDark ? darkCompactAlgorithm : defaultCompactAlgorithm;
};
