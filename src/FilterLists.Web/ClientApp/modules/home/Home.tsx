import * as React from "react";
import { IListDto } from "./IListDto";
import { ISoftwareDto } from "./ISoftwareDto";
import { ILanguageDto } from "./ILanguageDto";
import { Tagline } from "./Tagline";
import { ListsTable } from "./ListsTable";
import { IColumnVisibility } from "./ListsTable";

const columnVisibilityDefaults = [
    { column: "Software", visible: true },
    { column: "Tags", visible: true },
    { column: "Languages", visible: true },
    { column: "Updated Date", visible: true }
];

interface IProps {
    lists: IListDto[];
    ruleCount: number;
    software: ISoftwareDto[];
    languages: ILanguageDto[];
}

interface IState {
    columnVisibility: IColumnVisibility[];
    pageSize: number;
}

export class Home extends React.Component<IProps, IState> {
    constructor(props: any) {
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
                         <Tagline {...this.props} listCount={this.props.lists.length}/>
                         <ListsTable {...this.props}
                             pageSize={this.state.pageSize}
                             columnVisibility={this.state.columnVisibility}/>
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

    private findWithAttr(array: any, attr: any, value: any) {
        for (let i = 0; i < array.length; i += 1) {
            if (array[i][attr] === value) {
                return i;
            }
        }
        return -1;
    }
}