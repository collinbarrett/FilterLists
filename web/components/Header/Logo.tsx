import Link from "next/link";

export const Logo = () => (
  <Link href="/">
    {/* TODO: Use <Image> https://github.com/Azure/static-web-apps/discussions/1066#discussioncomment-5570779 */}
    <img
      src="/logo_filterlists.png"
      alt="FilterLists logo"
      width="189"
      height="44"
    />
  </Link>
);
