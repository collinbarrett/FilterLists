"use client";

import * as React from "react";
import { useTheme } from "next-themes";
import Image from "next/image";
import { ModeToggle } from "./mode-toggle";
import Link from "next/link";
import lightLogo from "./logo_filterlists.png";
import darkLogo from "./logo_filterlists_white.png";
import { useEffect, useState } from "react";

export function Header() {
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
    <header className="sticky top-0 flex h-16 items-center gap-4 border-b bg-background px-4 md:px-6">
      <nav className="flex flex-col gap-6 text-lg font-medium md:flex-row md:items-center md:gap-5 md:text-sm lg:gap-6">
        <Link
          href="#"
          className="flex items-center gap-2 text-lg font-semibold md:text-base"
        >
          <Image
            src={currentLogo}
            alt="FilterLists Logo"
            width={270}
            height={63}
            priority
          />
        </Link>
      </nav>
      <div className="ml-auto">
        <ModeToggle />
      </div>
    </header>
  );
}
