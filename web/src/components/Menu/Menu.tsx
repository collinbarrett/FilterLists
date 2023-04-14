import Link from "next/link";
import { Menu as MenuAntd } from "antd";
import { routes } from "./Routes";
import styles from "./Menu.module.css";
import { useMenu } from "./useMenu";

export const Menu = () => (
  <MenuAntd
    {...useMenu()}
    className={styles.menu}
    theme="dark"
    mode="horizontal"
    items={routes.map((item) => ({
      label: <Link href={item.route}>{item.description}</Link>,
      key: item.route,
    }))}
  />
);
