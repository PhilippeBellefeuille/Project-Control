function PXGantt(context, elem, props) {
    debugger;
    this.px_context = context;
    this.element = elem;
    this.ID = elem.id;

    gantt.init(this.ID);

    __px_cm(this).registerAutoSize(this, props);
}