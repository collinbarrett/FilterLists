import CollinMBarrettIconLight from "./collinmbarrett-icon-light.png";
import CollinMBarrettIconDark from "./collinmbarrett-icon-dark.png";
import { ImageThemed } from "@/components/image-themed";

export function CollinMBarrettLink() {
  return (
    <a
      className="flex items-center gap-2 hover:underline hover:underline-offset-4"
      href="https://collinmbarrett.com/"
      target="_blank"
      rel="noopener noreferrer"
    >
      <ImageThemed
        aria-hidden
        srcLight={CollinMBarrettIconLight}
        srcDark={CollinMBarrettIconDark}
        alt="Collin M. Barrett logo"
        width={16}
        height={16}
      />
      by Collin M. Barrett
    </a>
  );
}
