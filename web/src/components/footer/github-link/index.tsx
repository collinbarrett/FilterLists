import GitHubMarkLight from "./github-mark-light.svg";
import GitHubMarkDark from "./github-mark-dark.svg";
import { ThemeImage } from "@/components/theme-image";

export function GitHubLink() {
  return (
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
  );
}
