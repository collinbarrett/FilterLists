import { Software } from "@/src/interfaces";
import { SoftwareIcon } from "./SoftwareIcon";
import { AnchorToExternal } from "@/src/components/Common";

interface Props {
  software: Software[];
}

export const SoftwareIcons = ({ software }: Props) =>
  software.length ? (
    <>
      {software.map((software: Software, index: number) =>
        software.homeUrl ? (
          <AnchorToExternal
            href={software.homeUrl}
            title={`View ${software.name}'s homepage.`}
            key={index}
          >
            <SoftwareIcon id={software.id} />
          </AnchorToExternal>
        ) : (
          <SoftwareIcon key={index} id={software.id} />
        )
      )}
    </>
  ) : null;
