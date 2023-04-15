import { CheckCircleTwoTone, CloseCircleTwoTone } from "@ant-design/icons";
import { List } from "antd";
import styles from "./LicensePermissionsListItem.module.css";

interface Props {
  value: boolean;
  label: string;
}

export const LicensePermissionsListItem = ({ value, label }: Props) => (
  <List.Item>
    <div className={styles.container}>
      {value ? (
        <>
          <CheckCircleTwoTone twoToneColor="#52c41a" className={styles.icon} />
          <span>{label}</span>
        </>
      ) : (
        <>
          <CloseCircleTwoTone twoToneColor="#f5222d" className={styles.icon} />
          <span className={styles["not-permitted"]}>{label}</span>
        </>
      )}
    </div>
  </List.Item>
);
