import { Maintainer } from "@/src/interfaces";

export const getAnchorPropsFirst = (maintainer: Maintainer) => {
  if (maintainer.url) {
    return getAnchorPropsUrl(maintainer);
  } else if (maintainer.emailAddress) {
    return getAnchorPropsEmailAddress(maintainer);
  } else if (maintainer.twitterHandle) {
    return getAnchorPropsTwitter(maintainer);
  }
};

export const getAnchorPropsUrl = (maintainer: Maintainer) => ({
  href: maintainer.url,
  title: `View ${maintainer.name}'s homepage.`,
});

export const getAnchorPropsEmailAddress = (maintainer: Maintainer) => ({
  href: `mailto:${maintainer.emailAddress}`,
  title: `Email ${maintainer.name}.`,
});

export const getAnchorPropsTwitter = (maintainer: Maintainer) => ({
  href: `https://twitter.com/${maintainer.twitterHandle}`,
  title: `${maintainer.name} on Twitter`,
});
