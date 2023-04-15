import { Tag } from "@/src/interfaces";
import { Popover, Tag as AntTag } from "antd";

interface Props {
  tags: Tag[];
}

export const TagTags = ({ tags }: Props) =>
  tags.length ? (
    <>
      {tags.map((t: Tag, i: number) => (
        <Popover title={t.name} content={t.description} key={i}>
          <AntTag>{t.name}</AntTag>
        </Popover>
      ))}
    </>
  ) : null;
