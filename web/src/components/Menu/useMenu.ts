import { useState, useEffect } from "react";
import { useRouter } from "next/router";

export const useMenu = () => {
  const [selectedKeys, setSelectedKeys] = useState(["/"]);
  const router = useRouter();
  useEffect(() => {
    setSelectedKeys([router.asPath]);
  }, [router]);
  return { selectedKeys };
};
