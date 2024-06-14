import { Tag } from "antd";
import { Maintainer } from "../../interfaces/Maintainer";

interface Props {
  maintainers: Maintainer[];
}

export const MaintainerCloud = (props: Props) =>
  props.maintainers && props.maintainers.length ? (
    <div>
      {props.maintainers.map((m: Maintainer, i: number) =>
        m.url ? (
          <Tag key={i}>
            <a
              href={m.url}
              title={`View ${m.name}'s homepage.`}
              target="_blank"
              rel="noopener noreferrer"
            >
              {m.name}
            </a>
          </Tag>
        ) : (
          <Tag key={i}>{m.name}</Tag>
        ),
      )}
    </div>
  ) : null;
