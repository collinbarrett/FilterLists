import Image from "next/image";
import Link from "next/link";
import logo from "./logo_filterlists.png";

const Logo = () => (
  <Link href="/">
    <Image src={logo} alt="FilterLists logo" />
  </Link>
);
export default Logo;
