import { ThemeImage } from "@/components/theme-image";
import { ThemeToggle } from "@/components/theme-toggle";
import Link from "next/link";
import LogoLight from "./logo-filterlists-light.png";
import logoDark from "./logo-filterlists-dark.png";
import styles from "./logoHeader.module.css";

export function Header() {
  return (
    <header className="sticky top-0 z-50 w-full border-b bg-background/95 backdrop-blur supports-[backdrop-filter]:bg-background/60">
      <div className="flex h-20 items-center justify-between px-6">
        <div className="flex items-center">
          <Link href="/" aria-label="Go to homepage">
            <ThemeImage
              className={styles.logoHeader}
              srcLight={LogoLight}
              srcDark={logoDark}
              alt="FilterLists logo"
              width={429}
              height={100}
              priority
              fetchPriority="high"
            />
          </Link>
        </div>
        <div className="flex items-center">
          <ThemeToggle />
        </div>
      </div>
    </header>
  );
}
