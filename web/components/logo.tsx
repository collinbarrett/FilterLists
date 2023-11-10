import { useTheme } from "next-themes";
import { useMemo } from "react";
import Image from "next/image";

export function Logo() {
  const { resolvedTheme } = useTheme();

  const imageSrc = useMemo(() => {
    return resolvedTheme === "dark"
      ? "/logo_filterlists_white.png"
      : "/logo_filterlists.png";
  }, [resolvedTheme]);

  return (
    <Image
      src={imageSrc}
      alt="FilterLists Logo"
      width={300}
      height={70}
      priority
    />
  );
}

export default Logo;
