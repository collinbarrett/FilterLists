import Link from "next/link";
import { Menu as MenuAntd } from "antd";
import { useEffect, useState } from "react";
import { useRouter } from "next/router";
import { routes } from "./Routes";
import styles from "./Menu.module.css";

export const Menu = () => {
  const [currentMenuItem, setCurrentMenuItem] = useState("/");
  const router = useRouter();
  useEffect(() => {
    setCurrentMenuItem(router.asPath);
  }, [router]);
  return (
    <MenuAntd
      className={styles.menu}
      theme="dark"
      mode="horizontal"
      items={routes.map((item) => ({
        label: <Link href={item.route}>{item.description}</Link>,
        key: item.route,
      }))}
      selectedKeys={[currentMenuItem]}
    />
  );
};
