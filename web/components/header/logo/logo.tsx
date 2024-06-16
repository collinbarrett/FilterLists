"use client";

import * as React from "react";
import { useTheme } from "next-themes";
import Image from "next/image";
import lightLogo from "./logo_filterlists.png";
import darkLogo from "./logo_filterlists_white.png";
import { useEffect, useState } from "react";

export function Logo() {
  const { resolvedTheme } = useTheme();
  const [currentLogo, setCurrentLogo] = useState(lightLogo);

  useEffect(() => {
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
