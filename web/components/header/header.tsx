import * as React from "react";
import { ModeToggle } from "./mode-toggle";
import Link from "next/link";
import { Logo } from "./logo/logo";

export function Header() {
  return (
    <header className="sticky top-0 flex h-16 items-center gap-4 border-b bg-background px-4 md:px-6">
      <nav className="flex flex-col gap-6 text-lg font-medium md:flex-row md:items-center md:gap-5 md:text-sm lg:gap-6">
        <Link
          href="#"
          className="flex items-center gap-2 text-lg font-semibold md:text-base"
        >
          <Logo />
        </Link>
      </nav>
      <div className="ml-auto">
        <ModeToggle />
      </div>
    </header>
  );
}
