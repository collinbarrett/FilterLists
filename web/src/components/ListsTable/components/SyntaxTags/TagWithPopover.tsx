import { AnchorToExternal } from "@/src/components";
import { Syntax } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";
import { getAnchorPropsUrl } from "./getAnchorProps";

interface Props {
  syntax: Syntax;
}

export const TagWithPopover = ({ syntax }: Props) => (
  <Popover title={syntax.name} content={PopoverContent(syntax)}>
    <Tag>
      {syntax.url ? (
        <AnchorToExternal {...getAnchorPropsUrl(syntax)}>
          {syntax.name}
        </AnchorToExternal>
      ) : (
        syntax.name
      )}
    </Tag>
  </Popover>
);
