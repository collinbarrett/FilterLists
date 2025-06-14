import { CollinMBarrettLink } from "./collinmbarrett-link";
import { GitHubLink } from "./github-link";
import { ApiLink } from "./api-link";

export function Footer() {
  return (
    <footer className="row-start-3 flex gap-[24px] flex-wrap items-center justify-center">
      <CollinMBarrettLink />
      <ApiLink />
      <GitHubLink />
    </footer>
  );
}
