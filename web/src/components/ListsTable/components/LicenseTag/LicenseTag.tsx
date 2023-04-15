import { License } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { getColor } from "./getColor";
import { PopoverContent } from "./PopoverContent";

export const LicenseTag = (license: License) => (
  <Popover content={PopoverContent(license)} title={license.name}>
    <Tag color={getColor(license)}>
      {license.url ? (
        <a
          href={license.url}
          title={`View ${license.name}'s homepage.`}
          target="_blank"
          rel="noopener noreferrer"
        >
          {license.name}
        </a>
      ) : (
        <>{license.name}</>
      )}
    </Tag>
  </Popover>
);
