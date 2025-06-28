import { CollinMBarrettLink } from "./collinmbarrett-link";
import { GitHubLink } from "./github-link";
import { ApiLink } from "./api-link";

export function Footer() {
  return (
    <footer className="flex flex-wrap items-center justify-center gap-4 sm:gap-8 mb-2 sm:mb-3 overflow-x-auto whitespace-nowrap px-2 sm:px-0">
      <CollinMBarrettLink />
      <ApiLink />
      <GitHubLink />
    </footer>
  );
}
