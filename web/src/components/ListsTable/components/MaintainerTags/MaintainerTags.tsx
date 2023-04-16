import { Maintainer } from "@/src/interfaces";
import { Tag } from "antd";
import { TagAnchoredWithPopover } from "./TagAnchoredWithPopover";

interface Props {
  maintainers: Maintainer[];
}

export const MaintainerTags = ({ maintainers }: Props) =>
  maintainers.length ? (
    <>
      {maintainers.map((maintainer: Maintainer, index: number) =>
        maintainer.url ||
        maintainer.emailAddress ||
        maintainer.twitterHandle ? (
          <TagAnchoredWithPopover maintainer={maintainer} key={index} />
        ) : (
          <Tag key={index}>{maintainer.name}</Tag>
        )
      )}
    </>
  ) : null;
