import { Maintainer } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";
import { AnchorToExternal } from "@/src/components";

interface Props {
  maintainer: Maintainer;
}

export const TagAnchoredWithPopover = ({ maintainer }: Props) => (
  <Popover title={maintainer.name} content={PopoverContent(maintainer)}>
    <Tag>
      <AnchorToExternal {...getAnchorProps(maintainer)}>
        {maintainer.name}
      </AnchorToExternal>
    </Tag>
  </Popover>
);

const getAnchorProps = (maintainer: Maintainer) => {
  if (maintainer.url) {
    return {
      href: maintainer.url,
      title: `View ${maintainer.name}'s homepage.`,
    };
  } else if (maintainer.emailAddress) {
    return {
      href: `mailto:${maintainer.emailAddress}`,
      title: `Email ${maintainer.name}.`,
    };
  } else {
    return {
      href: `https://twitter.com/${maintainer.twitterHandle}`,
      title: `${maintainer.name} on Twitter`,
    };
  }
};
