import { CheckCircleTwoTone, CloseCircleTwoTone } from "@ant-design/icons";
import { List } from "antd";
import styles from "./SupportsAbpUriSchemeListItem.module.css";

interface Props {
  value: boolean;
}

export const SupportsAbpUriSchemeListItem = ({ value }: Props) => (
  <List.Item>
    <div className={styles.container}>
      {value ? (
        <CheckCircleTwoTone twoToneColor="#52c41a" className={styles.icon} />
      ) : (
        <CloseCircleTwoTone twoToneColor="#f5222d" className={styles.icon} />
      )}
      <span className={value ? undefined : styles["not-permitted"]}>
        Supports <code>abp</code> URI scheme
      </span>
    </div>
  </List.Item>
);
