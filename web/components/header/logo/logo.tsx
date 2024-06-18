"use client";

import React from "react";
import Image from "next/image";
import { useTheme } from "next-themes";

import darkLogo from "./logo_filterlists_white.png";
import lightLogo from "./logo_filterlists.png";

export function Logo() {
  const { resolvedTheme } = useTheme();
  const [currentLogo, setCurrentLogo] = React.useState(lightLogo);

  React.useEffect(() => {
    if (resolvedTheme === "dark") {
      setCurrentLogo(darkLogo);
    } else {
      setCurrentLogo(lightLogo);
    }
  }, [resolvedTheme]);

  return (
    <Image
      src={currentLogo}
      alt="FilterLists Logo"
      width={270}
      height={63}
      priority
    />
  );
}
