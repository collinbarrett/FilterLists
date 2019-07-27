import * as React from "react";

interface IProps {
    listCount: number;
    //ruleCount: number;
};

export const Oneliner = (props: IProps) =>
    props.listCount > 0/* && props.ruleCount > 0*/
    ? <p className="ml-2 mr-2">
            The independent, comprehensive directory of {/*}<strong>{props.ruleCount.toLocaleString()
          }</strong> unique rules across */}<strong>{props.listCount.toLocaleString()
          }</strong> filter and host lists for advertisements, trackers, malware, and annoyances.
      </p>
    : <p className="ml-2 mr-2">
          The independent, comprehensive directory of filter and host lists for advertisements, trackers, malware, and annoyances.
      </p>;