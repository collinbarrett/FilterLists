import { Tag } from "@/src/interfaces";
import { Popover, Tag as AntTag } from "antd";

interface Props {
  tags: Tag[];
}

export const TagTags = ({ tags }: Props) =>
  tags.length ? (
    <>
      {tags.map((tag: Tag, index: number) => (
        <Popover title={tag.name} content={tag.description} key={index}>
          <AntTag>{tag.name}</AntTag>
        </Popover>
      ))}
    </>
  ) : null;
