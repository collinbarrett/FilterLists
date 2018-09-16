import * as React from "react";
import { IListDto, ISoftwareDto, ILanguageDto } from "./interfaces";
import { Tagline, ListsTable, IColumnVisibility } from "./components";

const columnVisibilityDefaults = [
    { column: "Software", visible: true },
    { column: "Tags", visible: true },
    { column: "Languages", visible: true },
    { column: "Updated Date", visible: true }
];

interface IProps {
    languages: ILanguageDto[];
    lists: IListDto[];
    ruleCount: number;
    software: ISoftwareDto[];
}

interface IState {
    columnVisibility: IColumnVisibility[];
    pageSize: number;
}

export class Home extends React.Component<IProps, IState> {
    constructor(props: IProps) {
        super(props);
        this.state = {
            columnVisibility: columnVisibilityDefaults,
            pageSize: 20
        };
        this.updatePageSize = this.updatePageSize.bind(this);
    }

    componentDidMount() {
        this.updatePageSize();
    }

    render() {
        return this.props.lists
                   ? <div>
                         <Tagline listCount={this.props.lists.length} ruleCount={this.props.ruleCount}/>
                         <ListsTable {...this.props} {...this.state}/>
                         {this.renderColumnVisibilityCheckboxes()}
                     </div>
                   : null;
    }

    updatePageSize() {
        this.setState({
            pageSize: Math.max(Math.floor((window.innerHeight - 386) / 52), 5)
        });
    }

    private renderColumnVisibilityCheckboxes() {
        return <div className="d-none d-md-block text-right">
                   Visible:&nbsp;&nbsp;{this.state.columnVisibility.map(
                   (c: IColumnVisibility, i) => this.renderColumnVisibilityCheckbox(c, i))}
               </div>;
    };

    private renderColumnVisibilityCheckbox(props: IColumnVisibility, key: number) {
        return <div className="form-check form-check-inline" key={key}>
                   <input className="form-check-input"
                          type="checkbox"
                          id={`checkbox${props.column.replace(/\s+/g, "")}`}
                          defaultChecked={props.visible}
                          onChange={() => this.checkColumn(props)}/>
                   <label className="form-check-label"
                          htmlFor={`checkbox${props.column.replace(/\s+/g, "")}`}>
                       {props.column}
                   </label>
               </div>;
    }

    private checkColumn(props: IColumnVisibility) {
        const columnVisibility = this.state.columnVisibility;
        const index = this.findWithAttr(columnVisibility, "column", props.column);
        columnVisibility[index].visible = !columnVisibility[index].visible;
        this.forceUpdate();
    }

    private findWithAttr(array: any, attr: string, value: string) {
        for (let i = 0; i < array.length; i += 1) {
            if (array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}