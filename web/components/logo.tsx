import Image from "next/image";
import Link from "next/link";

const Logo = () => (
  <Link href="/">
    <Image
      src="/logo_filterlists.png"
      alt="FilterLists logo"
      width={189}
      height={44}
    />
  </Link>
);
export default Logo;
