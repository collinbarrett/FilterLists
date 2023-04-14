import Link from "next/link";
import logo from "./logo_filterlists.png";
import Image from "next/image";

export const Logo = () => (
  <Link href="/">
    <Image src={logo} alt="FilterLists logo" priority />
  </Link>
);
