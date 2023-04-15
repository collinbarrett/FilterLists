import { Maintainer } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";

interface Props {
  maintainers: Maintainer[];
}

export const MaintainerTags = ({ maintainers }: Props) =>
  maintainers.length ? (
    <>
      {maintainers.map((m: Maintainer, i: number) =>
        m.url || m.emailAddress || m.twitterHandle ? (
          <Popover title={m.name} content={PopoverContent(m)} key={i}>
            <Tag>{m.name}</Tag>
          </Popover>
        ) : (
          <Tag key={i}>{m.name}</Tag>
        )
      )}
    </>
  ) : null;
