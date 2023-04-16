import { Software } from "@/src/interfaces";
import { SoftwareIconWithPopover } from "./SoftwareIconWithPopover";

interface Props {
  software: Software[];
}

export const SoftwareIcons = ({ software }: Props) =>
  software.length ? (
    <>
      {software.map((software: Software, index: number) => (
        <SoftwareIconWithPopover software={software} key={index} />
      ))}
    </>
  ) : null;
