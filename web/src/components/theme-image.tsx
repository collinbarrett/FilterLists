"use client";

import { useState, useEffect } from "react";
import Image, { type ImageProps, type StaticImageData } from "next/image";
import { useTheme } from "next-themes";

type ThemedImageProps = Omit<ImageProps, "src" | "alt"> & {
  srcLight: string | StaticImageData;
  srcDark: string | StaticImageData;
  alt: string;
};

export function ThemeImage({
  srcLight,
  srcDark,
  alt,
  ...props
}: ThemedImageProps) {
  const { resolvedTheme } = useTheme();
  const [mounted, setMounted] = useState(false);

  useEffect(() => {
    setMounted(true);
  }, []);

  const src = resolvedTheme === "dark" ? srcDark : srcLight;

  if (!mounted) {
    return <Image src={srcLight} alt={alt} {...props} unoptimized />;
  }

  return <Image src={src} alt={alt} {...props} />;
}
