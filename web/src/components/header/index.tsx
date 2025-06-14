import { ImageThemed } from "@/components/image-themed";
import { ThemeToggle } from "../theme-toggle";
import LogoLight from "./logo-filterlists-light.png";
import logoDark from "./logo-filterlists-dark.png";
import styles from "./logoHeader.module.css";

export function Header() {
  return (
    <header className="sticky top-0 z-50 w-full border-b bg-background/95 backdrop-blur supports-[backdrop-filter]:bg-background/60">
      <div className="container flex h-20 items-center px-2 sm:px-0">
        <div className="flex items-center flex-1 space-x-4">
          <div className="mr-4 flex-shrink-0">
            <ImageThemed
              className={styles.logoHeader}
              srcLight={LogoLight}
              srcDark={logoDark}
              alt="FilterLists logo"
              width={429}
              height={100}
              priority
            />
          </div>
          <div className="flex flex-1 items-center justify-end space-x-4">
            <nav className="flex items-center space-x-1">
              <ThemeToggle />
            </nav>
          </div>
        </div>
      </div>
    </header>
  );
}
