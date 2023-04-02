import { Software } from "../../interfaces/Software";
import { SoftwareIcon } from "./SoftwareIcon";

interface Props {
  software: Software[];
  showLabel?: boolean;
}

export const SoftwareCloud = (props: Props) =>
  props.software && props.software.length ? (
    <div>
      {props.showLabel && <h3>{`Software:`}</h3>}
      {props.software.map((s: Software, i: number) =>
        s.homeUrl ? (
          <a
            key={i}
            href={s.homeUrl}
            target="_blank"
            rel="noopener noreferrer"
            style={{
              display: "inline-block",
              height: "20px",
            }}
          >
            <SoftwareIcon id={s.id} />
          </a>
        ) : (
          <SoftwareIcon key={i} id={s.id} />
        )
      )}
    </div>
  ) : null;
