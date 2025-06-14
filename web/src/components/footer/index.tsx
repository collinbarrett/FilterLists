import { CollinMBarrettLink } from "./collinmbarrett-link";
import { GitHubLink } from "./github-link";
import { ApiLink } from "./api-link";

export function Footer() {
  return (
    <footer className="flex flex-wrap items-center justify-center gap-2 sm:gap-[24px] mb-2 sm:mb-3 overflow-x-auto whitespace-nowrap">
      <CollinMBarrettLink />
      <ApiLink />
      <GitHubLink />
    </footer>
  );
}
