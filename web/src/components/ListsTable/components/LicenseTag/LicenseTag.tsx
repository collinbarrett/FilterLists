import { License } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { getColor } from "./getColor";
import { PopoverContent } from "./PopoverContent";
import { AnchorToExternal } from "@/src/components";

export const LicenseTag = (license: License) => (
  <Popover content={PopoverContent(license)} title={license.name}>
    <Tag color={getColor(license)}>
      {license.url ? (
        <AnchorToExternal
          href={license.url}
          title={`View ${license.name}'s homepage.`}
        >
          {license.name}
        </AnchorToExternal>
      ) : (
        <>{license.name}</>
      )}
    </Tag>
  </Popover>
);
