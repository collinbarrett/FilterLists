import Image from "next/image";
import { FileJson2 } from "lucide-react";
import CollinMBarrettIcon from "../assets/collinmbarrett-icon.png";
import GitHubMark from "../assets/github-mark.svg";

export default function Home() {
  return (
    <div className="grid grid-rows-[20px_1fr_20px] items-center justify-items-center min-h-screen p-8 pb-20 gap-16 sm:p-20 font-[family-name:var(--font-geist-sans)]">
      <main className="flex flex-col gap-[32px] row-start-2 items-center sm:items-start"></main>
      <footer className="row-start-3 flex gap-[24px] flex-wrap items-center justify-center">
        {/* TODO: toggle images in dark mode */}
        <a
          className="flex items-center gap-2 hover:underline hover:underline-offset-4"
          href="https://collinmbarrett.com/"
          target="_blank"
          rel="noopener noreferrer"
        >
          <Image
            aria-hidden
            src={CollinMBarrettIcon}
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
          <Image
            aria-hidden
            src={GitHubMark}
            alt="GitHub Logomark"
            width={16}
            height={16}
          />
          GitHub
        </a>
      </footer>
    </div>
  );
}
