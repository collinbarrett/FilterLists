import { License } from "@/src/interfaces";
import { Tag } from "antd";

export const LicenseTag = (license: License) => (
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
);

function getColor(license: License) {
  switch (
    `${license.permitsDistribution}-${license.permitsModification}-${license.permitsCommercialUse}`
  ) {
    case "true-true-true":
      return "cyan";
    case "true-true-false":
      return "green";
    case "true-false-true":
      return "lime";
    case "true-false-false":
      return "gold";
    case "false-true-true":
      return "orange";
    case "false-true-false":
      return "volcano";
    case "false-false-true":
      return "red";
    case "false-false-false":
      return "magenta";
    default:
      return undefined;
  }
}
