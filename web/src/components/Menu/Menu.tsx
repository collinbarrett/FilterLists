import Link from "next/link";
import { Menu as MenuAntd } from "antd";
import { routes } from "./Routes";
import styles from "./Menu.module.css";
import { useMenu } from "./useMenu";

export const Menu = () => (
  <MenuAntd
    {...useMenu()}
    className={styles.menu}
    // TODO: toggle with theme switcher
    theme="dark"
    mode="horizontal"
    items={routes.map((route) => ({
      label: <Link href={route.path}>{route.description}</Link>,
      key: route.path,
    }))}
  />
);
