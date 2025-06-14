import { FileJson2 } from "lucide-react";
import CollinMBarrettIconLight from "../assets/collinmbarrett-icon-light.png";
import CollinMBarrettIconDark from "../assets/collinmbarrett-icon-dark.png";
import GitHubMarkLight from "../assets/github-mark-light.svg";
import GitHubMarkDark from "../assets/github-mark-dark.svg";
import { ThemeImage } from "@/components/theme-image";

export function SiteFooter() {
  return (
    <footer className="row-start-3 flex gap-[24px] flex-wrap items-center justify-center">
      <a
        className="flex items-center gap-2 hover:underline hover:underline-offset-4"
        href="https://collinmbarrett.com/"
        target="_blank"
        rel="noopener noreferrer"
      >
        <ThemeImage
          aria-hidden
          srcLight={CollinMBarrettIconLight}
          srcDark={CollinMBarrettIconDark}
          alt="Collin M. Barrett logo"
          width={16}
          height={16}
        />
        by Collin M. Barrett
      </a>
      <a
        className="flex items-center gap-2 hover:underline hover:underline-offset-4"
        href="https://api.filterlists.com/"
        target="_blank"
        rel="noopener noreferrer"
      >
        <FileJson2 width={16} height={16} />
        API
      </a>
      <a
        className="flex items-center gap-2 hover:underline hover:underline-offset-4"
        href="https://github.com/collinbarrett/FilterLists"
        target="_blank"
        rel="noopener noreferrer"
      >
        <ThemeImage
          aria-hidden
          srcLight={GitHubMarkLight}
          srcDark={GitHubMarkDark}
          alt="GitHub Logomark"
          width={16}
          height={16}
        />
        GitHub
      </a>
    </footer>
  );
}
