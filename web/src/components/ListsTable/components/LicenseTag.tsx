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

const getColor = (license: License): string | undefined =>
  permissionsColorMap.get(
    `${license.permitsDistribution}-${license.permitsModification}-${license.permitsCommercialUse}`
  );

const permissionsColorMap = new Map<string, string>([
  ["true-true-true", "cyan"],
  ["true-true-false", "green"],
  ["true-false-true", "lime"],
  ["true-false-false", "gold"],
  ["false-true-true", "orange"],
  ["false-true-false", "volcano"],
  ["false-false-true", "red"],
  ["false-false-false", "magenta"],
]);
