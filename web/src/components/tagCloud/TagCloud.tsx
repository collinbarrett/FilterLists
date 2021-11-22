import { Tag } from "antd";
import { Tag as TagInterface } from "../../interfaces/Tag";

interface Props {
  tags: TagInterface[];
  showLabel?: boolean;
}

export const TagCloud = (props: Props) =>
  props.tags && props.tags.length ? (
    <div>
      {props.showLabel && <h3>{`Tag${props.tags.length > 1 ? "s" : ""}:`}</h3>}
      {props.tags.map((t: TagInterface, i: number) => (
        <Tag key={i} title={t.description}>
          {t.name}
        </Tag>
      ))}
    </div>
  ) : null;
