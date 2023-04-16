import { Maintainer } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";
import { AnchorToExternal } from "@/src/components";
import { getAnchorPropsFirst } from "./getAnchorProps";

interface Props {
  maintainer: Maintainer;
}

export const TagWithPopover = ({ maintainer }: Props) => (
  <Popover title={maintainer.name} content={PopoverContent(maintainer)}>
    <Tag>
      <AnchorToExternal {...getAnchorPropsFirst(maintainer)}>
        {maintainer.name}
      </AnchorToExternal>
    </Tag>
  </Popover>
);
