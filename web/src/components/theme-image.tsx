"use client";

import { useTheme } from "next-themes";
import Image, { ImageProps, StaticImageData } from "next/image";
import { useEffect, useState } from "react";

type Props = Omit<ImageProps, "src" | "loading"> & {
  srcLight: string | StaticImageData;
  srcDark: string | StaticImageData;
};

export const ThemeImage = (props: Props) => {
  const { srcLight, srcDark, alt, priority, ...rest } = props;
  const { resolvedTheme } = useTheme();
  const [mounted, setMounted] = useState(false);

  useEffect(() => setMounted(true), []);

  if (!mounted) {
    return null;
  }

  if (
    process.env.NODE_ENV === "development" &&
    priority === true &&
    alt !== "FilterLists logo"
  ) {
    console.warn(
      `ThemeImage: [alt="${alt}"] Using priority will cause both light and dark images to be loaded. Only use for LCP images.`,
    );
  }

  const src = resolvedTheme === "dark" ? srcDark : srcLight;

  return <Image {...rest} src={src} alt={alt} priority={priority} />;
};
