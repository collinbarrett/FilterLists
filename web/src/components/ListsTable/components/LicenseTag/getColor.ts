import { License } from "@/src/interfaces";

export const getColor = ({
  permitsDistribution,
  permitsModification,
  permitsCommercialUse,
}: License): string | undefined =>
  permissionsColorMap.get(
    `${permitsDistribution}-${permitsModification}-${permitsCommercialUse}`
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
