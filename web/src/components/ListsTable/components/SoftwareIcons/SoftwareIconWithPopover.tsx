import { AnchorToExternal } from "@/src/components";
import { Software } from "@/src/interfaces";
import { Popover } from "antd";
import { PopoverContent } from "./PopoverContent";
import { SoftwareIcon } from "./SoftwareIcon";
import { getAnchorPropsHomeUrl } from "./getAnchorProps";

interface Props {
  software: Software;
}

export const SoftwareIconWithPopover = ({ software }: Props) => (
  <Popover title={software.name} content={PopoverContent(software)}>
    {software.homeUrl ? (
      <AnchorToExternal {...getAnchorPropsHomeUrl(software)}>
        <SoftwareIcon id={software.id} />
      </AnchorToExternal>
    ) : (
      <SoftwareIcon id={software.id} />
    )}
  </Popover>
);
