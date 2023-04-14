import { License } from "@/src/interfaces";
import { Tag } from "antd";

export const LicenseTag = (license: License) => (
  <Tag>
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
);
