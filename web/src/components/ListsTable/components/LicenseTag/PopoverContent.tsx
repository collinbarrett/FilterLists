import { List } from "antd";
import { LicensePermissionsListItem } from "./LicensePermissionsListItem";
import { License } from "@/src/interfaces";

export const PopoverContent = ({
  permitsDistribution,
  permitsModification,
  permitsCommercialUse,
}: License) => (
  <List
    size="small"
    dataSource={[
      { value: permitsDistribution, label: "Permits Distribution" },
      { value: permitsModification, label: "Permits Modification" },
      {
        value: permitsCommercialUse,
        label: "Permits Commercial Use",
      },
    ]}
    renderItem={(permission) => (
      <LicensePermissionsListItem
        label={permission.label}
        value={permission.value}
        key={permission.label}
      />
    )}
  />
);
