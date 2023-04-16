import { Software } from "@/src/interfaces";

export const getAnchorPropsHomeUrl = (software: Software) => ({
  href: software.homeUrl,
  title: `View ${software.name}'s homepage.`,
});
