import { Syntax } from "@/src/interfaces";

export const getAnchorPropsUrl = (syntax: Syntax) => ({
  href: syntax.url,
  title: `View ${syntax.name}'s homepage.`,
});
