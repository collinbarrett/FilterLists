import Link from "next/link";
import { Menu as MenuAntd } from "antd";
import { useEffect, useState } from "react";
import { useRouter } from "next/router";

const routes = [
  {
    route: "/",
    description: "Lists",
  },
  {
    route: "/about",
    description: "About",
  },
];

const Menu = () => {
  const [current, setCurrent] = useState("/");
  const router = useRouter();
  useEffect(() => {
    setCurrent(router.asPath);
  }, [router]);
  return (
    <MenuAntd
      style={{ flex: "auto", minWidth: 0 }}
      theme="dark"
      mode="horizontal"
      items={routes.map((item) => ({
        label: <Link href={item.route}>{item.description}</Link>,
        key: item.route,
      }))}
      selectedKeys={[current]}
    />
  );
};
export default Menu;
