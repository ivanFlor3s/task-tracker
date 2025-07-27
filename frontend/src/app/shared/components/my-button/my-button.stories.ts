import { Meta, StoryObj } from '@storybook/angular';
import { MyButtonComponent } from './my-button.component';

const meta: Meta<MyButtonComponent> = {
  title: 'Components/MyButton',
  component: MyButtonComponent,
  tags: ['autodocs'],
  argTypes: {
    color: {
      control: 'select',
      options: ['primary', 'secondary', 'danger'],
    },
    clicked: { action: 'clicked' },
  },
};

export default meta;
type Story = StoryObj<MyButtonComponent>;

export const Primary: Story = {
  args: {
    label: 'Aceptar',
    color: 'primary',
    disabled: false,
  },
};

export const Secondary: Story = {
  args: {
    label: 'Cancelar',
    color: 'secondary',
  },
};

export const Danger: Story = {
  args: {
    label: 'Eliminar',
    color: 'danger',
  },
};

export const Disabled: Story = {
  args: {
    label: 'No disponible',
    color: 'primary',
    disabled: true,
  },
};
